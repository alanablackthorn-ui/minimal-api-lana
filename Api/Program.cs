using MinimalApi;

Console.WriteLine("🚀 Inicializando Minimal API personalizada por Lana...");

IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });
}

// 🌸 Log extra de inicialização personalizada
Console.WriteLine("🌼 API da Lana iniciada com sucesso! Preparando motores...");

Console.WriteLine("✨ Aplicação pronta para receber requisições!");
CreateHostBuilder(args).Build().Run();

