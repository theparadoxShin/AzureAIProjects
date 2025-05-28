using Azure;
using Azure.AI.Inference;
using Azure.AI.Projects;
using Azure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try{

                var projectEndpoint = "https://bentedom-0579-resource.services.ai.azure.com/api/projects/bentedom-0579";
                var projectClient = new AIProjectClient(new Uri(projectEndpoint), new DefaultAzureCredential());

                var allConnections = projectClient.GetConnectionsClient();

                ChatCompletionsClient chatClient = projectClient.GetChatCompletionsClient();

                Console.WriteLine("Enter a question:");
                var user_prompt = Console.ReadLine();

                var requestOptions = new ChatCompletionsOptions()
                {
                    Model = "gpt-4o",
                    Messages =
                        {
                            new ChatRequestSystemMessage("You are a helpful AI assistant that answers questions."),
                            new ChatRequestUserMessage(user_prompt),
                        }
                };

                Response<ChatCompletions> response = chatClient.Complete(requestOptions);
                Console.WriteLine(response.Value.Content);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return;
            }

            
        }
    }
}
