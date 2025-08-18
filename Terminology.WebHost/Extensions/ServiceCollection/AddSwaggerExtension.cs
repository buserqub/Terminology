namespace Terminology.WebHost.Extensions.ServiceCollection;

/// <summary>
/// Класс-контейнер для регистрации Swagger
/// </summary>
public static class AddSwaggerExtension
{
    /// <summary>
    /// Зарегистрировать Swagger
    /// </summary>
    /// <param name="services">Коллекция сервисов</param>
    /// <param name="configuration">Конфигурация</param>
    public static void AddSwagger(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSwaggerGen(options =>
        {
            var filePath = Path.Combine(AppContext.BaseDirectory, $"Terminology.Pres.xml");

            options.IncludeXmlComments(filePath);
        });
    }
}
