using System;
using System.IO;

namespace ScaffoldMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: dotnet run <actionName> <namespace>");
                return;
            }

            var actionName = args[0];
            var namespaceName = args[1];


            string path = Path.Combine(Directory.GetCurrentDirectory(), actionName);
            Directory.CreateDirectory(path);

            var commandClassName = $"{actionName}Command";
            var commandHandlerClassName = $"{actionName}CommandHandler";
            var commandValidatorClassName = $"{actionName}CommandValidator";


            string commandClass = $"{commandClassName}.cs";
            string commandHandlerClass = $"{commandHandlerClassName}.cs";
            string commandValidatorClass = $"{commandValidatorClassName}.cs";

            File.WriteAllText(Path.Combine(path, commandClass),
$@"using System;
using MediatR;

namespace {namespaceName}.{actionName}
{{
    public class {commandClassName} : {actionName}Request, IRequest<{actionName}Result>
    {{
        
    }}
}}
");

            File.WriteAllText(Path.Combine(path, commandHandlerClass),
$@"using System;
using MediatR;

namespace {namespaceName}.{actionName}
{{
    public class {commandHandlerClassName} : IRequestHandler<{actionName}Command, {actionName}Result>
    {{
    public async Task<{actionName}Result> Handle({actionName}Command request, CancellationToken cancellationToken)
        {{
            throw new NotImplementedException();
        }}
    }}
}}");

            File.WriteAllText(Path.Combine(path, commandValidatorClass),
$@"using System;
using FluentValidation;

namespace {namespaceName}.{actionName}
{{
    public class {commandValidatorClassName} : AbstractValidator<{actionName}Command>
    {{
        public {commandValidatorClassName}()
        {{
            
        }}
    }}
}}");

            Console.WriteLine("Classes created successfully!");
        }
    }
}
