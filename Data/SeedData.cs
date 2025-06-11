using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using EspaçoVerdeLogin.Models; // Certifique-se de que este namespace está correto para sua classe Users

namespace EspaçoVerdeLogin.Data.Seed
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            // Crie um escopo de serviço para obter os serviços necessários.
            // Isso garante que os serviços sejam liberados corretamente após o uso.
            using (var scope = serviceProvider.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Users>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                // --- 1. Definir e Criar Roles (Funções) se elas não existirem ---
                // Alterado para conter apenas as roles "Administrador" e "UsuarioComum"
                string[] roleNames = { "Administrador", "UsuarioComum" };

                foreach (var roleName in roleNames)
                {
                    // Verifica se a role já existe no banco de dados
                    if (!await roleManager.RoleExistsAsync(roleName))
                    {
                        // Se não existir, cria a role
                        var roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                        if (!roleResult.Succeeded)
                        {
                            // Em caso de falha na criação da role, imprime os erros no console
                            Console.WriteLine($"Erro ao criar role '{roleName}':");
                            foreach (var error in roleResult.Errors)
                            {
                                Console.WriteLine($"- {error.Description}");
                            }
                        }
                    }
                }

                // --- 2. Criar um Usuário Administrador padrão se ele não existir ---
                var adminEmail = "admin@seusistema.com"; // Email do usuário administrador
                var adminPassword = "Senha@123";          // Senha forte para o administrador

                // Tenta encontrar o usuário administrador pelo email
                var adminUser = await userManager.FindByEmailAsync(adminEmail);

                // Se o usuário administrador não existir
                if (adminUser == null)
                {
                    // Cria uma nova instância do seu modelo de usuário (Users)
                    adminUser = new Users
                    {
                        UserName = adminEmail,      // O UserName geralmente é o mesmo que o Email para login
                        Email = adminEmail,
                        RazaoSocial = "Administrador Master", // Informações adicionais da sua classe Users
                        CNPJ = "00.000.000/0001-00",
                        EmailConfirmed = true       // Marca o email como confirmado para permitir o login imediato
                    };

                    // Tenta criar o usuário com a senha definida
                    var result = await userManager.CreateAsync(adminUser, adminPassword);

                    if (result.Succeeded)
                    {
                        // Se a criação do usuário for bem-sucedida, atribui a role "Administrador" a ele
                        await userManager.AddToRoleAsync(adminUser, "Administrador");
                        Console.WriteLine($"Usuário '{adminEmail}' criado e adicionado à role 'Administrador'.");
                    }
                    else
                    {
                        // Em caso de falha na criação do usuário, imprime os erros no console
                        Console.WriteLine($"Erro ao criar usuário '{adminEmail}':");
                        foreach (var error in result.Errors)
                        {
                            Console.WriteLine($"- {error.Description}");
                        }
                    }
                }
                else
                {
                    // Se o usuário já existe, garante que ele está na role "Administrador"
                    if (!await userManager.IsInRoleAsync(adminUser, "Administrador"))
                    {
                        await userManager.AddToRoleAsync(adminUser, "Administrador");
                        Console.WriteLine($"Usuário '{adminEmail}' já existia e foi adicionado à role 'Administrador'.");
                    }
                    else
                    {
                        Console.WriteLine($"Usuário '{adminEmail}' já existe e já está na role 'Administrador'.");
                    }
                }
            }
        }
    }
}