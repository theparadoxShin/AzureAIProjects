using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.AI.Projects;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try{

                var projectEndpoint = "https://bentedom-0579-resource.services.ai.azure.com/api/projects/bentedom-0579";
                var projectClient = new AIProjectClient(new Uri(projectEndpoint), new DefaultAzureCredential());

                var allProjects = projectClient.GetConnectionsClient();

                Console.WriteLine("Enter your age");

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return;
            }

            
        }
    }
}
