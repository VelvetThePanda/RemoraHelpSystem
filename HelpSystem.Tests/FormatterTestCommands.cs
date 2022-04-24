using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Remora.Commands.Attributes;
using Remora.Commands.Groups;
using Remora.Discord.API.Abstractions.Objects;
using Remora.Discord.Commands.Conditions;
using Remora.Results;

namespace HelpSystem.Tests;

[ExcludeFromCodeCoverage]
public class FormatterTestCommands : CommandGroup
{
    [Command("parameterless")]
    public async Task<IResult> Parameterless() => default;
    
    [Command("parameterized")]
    public async Task<IResult> Parameterized(string parameter) => default;
    
    [Command("optional-parameterized")]
    public async Task<IResult> OptionalParameterized(string parameter = null) => default;
    
    [Command("described-parameter")]
    public async Task<IResult> DescribedParameter([Description("description")] string parameter) => default;
    
    [Command("multi-parameterized")]
    public async Task<IResult> MultiParameterized(string parameter1, string parameter2) => default;
    
    [Command("multi-parameterized-optional")]
    public async Task<IResult> MultiParameterizedWithDefault(string parameter1, string parameter2 = "default") => default;
    
    [Command("short-named-option")]
    public async Task<IResult> ShortNamedOption([Option('o')] string parameter) => default;
    
    [Command("long-named-option")]
    public async Task<IResult> LongNamedOption([Option("option")] string parameter) => default;
    
    [Command("short-long-named-option")]
    public async Task<IResult> ShortLongNamedOption([Option('o', "option")] string parameter) => default;
    
    [Command("optional-short-named-option")]
    public async Task<IResult> OptionalShortNamedOption([Option('o')] string parameter = null) => default;
    
    [Command("optional-long-named-option")]
    public async Task<IResult> OptionalLongNamedOption([Option("option")] string parameter = null) => default;
    
    [Command("optional-short-long-named-option")]
    public async Task<IResult> OptionalShortLongNamedOption([Option('o', "option")] string parameter = null) => default;
    
    [Command("short-named-switch")]
    public async Task<IResult> NamedSwitch([Switch('s')] bool parameter = false) => default;

    [Command("long-named-switch")]
    public async Task<IResult> LongNamedSwitch([Switch("switch")] bool parameter = false) => default;
    
    [Command("short-long-named-switch")]
    public async Task<IResult> ShortLongNamedSwitch([Switch('s', "switch")] bool parameter = false) => default;
    
    [Command("descriptionless")]
    public async Task<IResult> CommandWithoutDescription() => default;
    
    [Command("descriptioned")]
    [Description("Descriptioned command")]
    public async Task<IResult> CommandWithDescription() => default;
    
    [Command("permissioned")]
    [RequireDiscordPermission(DiscordPermission.SendMessages)]
    public async Task<IResult> CommandWithPermission() => default;
    
    [Command("overload")]
    public async Task<IResult> OverloadedCommand(int arg) => default;
    
    [Command("overload")]
    public async Task<IResult> OverloadedCommand(string arg) => default;
    
    [Group("standalone-group")]
    public class StandaloneGroup : CommandGroup
    {
        [Command("command")]
        public async Task<IResult> StandaloneCommand() => default;
    }
    
    [Group("multi-child-group")]
    public class MultiChildGroup : CommandGroup
    {
        [Command("command-1")]
        public async Task<IResult> Command1() => default;
        
        [Command("command-2")]
        public async Task<IResult> Command2() => default;
    }

    [Command("parameterless-executable-group")]
    public async Task<IResult> ExecutableGroupCommand() => default;
    
    [Group("parameterless-executable-group")]
    public class ExecutableGroup : CommandGroup
    {
        [Command("command")]
        public async Task<IResult> ExecutableCommand() => default;
    }
    
    [Command("parameterized-executable-group")]
    public async Task<IResult> ParameterizedExecutableGroupCommand(string parameter) => default;
    
    [Group("parameterized-executable-group")]
    public class ParameterizedExecutableGroup : CommandGroup
    {
        [Command("command")]
        public async Task<IResult> ParameterizedExecutableCommand(string parameter) => default;
    }
    
    [Command("overloaded-parameterized-executable-group")]
    public async Task<IResult> OverloadedParameterizedExecutableGroupCommand() => default;
    
    [Command("overloaded-parameterized-executable-group")]
    public async Task<IResult> OverloadedParameterizedExecutableGroupCommand(string parameter) => default;
    
    [Group("overloaded-parameterized-executable-group")]
    public class OverloadedParameterizedExecutableGroup : CommandGroup
    {
        [Command("command")]
        public async Task<IResult> OverloadedParameterizedExecutableCommand(int parameter) => default;
        
        [Command("command")]
        public async Task<IResult> OverloadedParameterizedExecutableCommand(string parameter) => default;
    }
    
    [Command("described-executable-group")]
    [Description("Command description")]
    public async Task<IResult> DescribedExecutableGroupCommand() => default;
    
    [Group("described-executable-group")]
    [Description("Group description")]
    public class DescribedExecutableGroup : CommandGroup
    {
        [Command("command")]
        public async Task<IResult> DescribedExecutableCommand() => default;
    }
    
    [Command("described-executable-group-2")]
    [Description("Command description")]
    public async Task<IResult> DescribedExecutableGroup2Command() => default;
    
    [Group("described-executable-group-2")]
    public class DescribedExecutableGroup2 : CommandGroup
    {
        [Command("command")]
        [Description("Command description")]
        public async Task<IResult> DescribedExecutableCommand() => default;
    }
    
    
    
    [Group("complex-group")]
    public class ComplexGroup : CommandGroup
    {
        [Command("command")]
        public async Task<IResult> ComplexCommand() => default;
        
        [Command("overload")]
        public async Task<IResult> OverloadedCommand(int arg) => default;
        
        [Command("overload")]
        public async Task<IResult> OverloadedCommand(string arg) => default;
        
        [Group("nested-group")]
        public class NestedGroup : CommandGroup
        {
            [Command("command")]
            public async Task<IResult> NestedCommand() => default;
        }
    }
    
}