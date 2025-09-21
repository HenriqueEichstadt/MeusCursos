using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using MicrosoftSemanticKernelTests.Plugins;

namespace MicrosoftSemanticKernelTests;

public class Program
{
    public async static Task Main(string[] args)
    {
        var builder = Kernel.CreateBuilder()
            /*.AddOllamaChatCompletion(
                modelId: "llama3.1:latest",
                endpoint: new Uri("http://localhost:11434")
            )*/
            .AddOpenAIChatCompletion(
                modelId: "gpt-4o-mini",
                apiKey: "OPEN_AI_TOKEN"
            )
            ;

        builder.Services.AddLogging(x => x.AddConsole().SetMinimumLevel(LogLevel.Trace));

        var app = builder.Build();

        var chatCompletionService = app.GetRequiredService<IChatCompletionService>();

        app.Plugins.AddFromType<ProductPlugin>("Plugins");

        OpenAIPromptExecutionSettings settings = new()
        {
            FunctionChoiceBehavior = FunctionChoiceBehavior.Auto()
        };

        var history = new ChatHistory();

        string? input;
        do
        {
          
            Console.Write("User > ");
            input = Console.ReadLine();

            history.AddUserMessage(input);

            ChatMessageContent? result = await chatCompletionService.GetChatMessageContentAsync(
                history, 
                settings, 
                kernel: app
                );
            Console.WriteLine("Assistant > " + result);

            history.AddMessage(result.Role, result.Content ?? string.Empty);
        }
        while (input is not null);

    }
}
