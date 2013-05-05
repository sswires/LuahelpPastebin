using LuahelpPastebin.Models;

namespace LuahelpPastebin.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LuahelpPastebin.Models.PastebinContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LuahelpPastebin.Models.PastebinContext context)
        {
            context.Languages.AddOrUpdate(
                p => p.Id,
                new Language { Id = "actionscript3", Description = "ActionScript 3" },
                new Language { Id = "applescript", Description = "AppleScript" },
                new Language { Id = "bash", Description = "Bash/Shell" },
                new Language { Id = "c", Description = "C" },
                new Language { Id = "cpp", Description = "C++" },
                new Language { Id = "c#", Description = "C#" },
                new Language { Id = "cf", Description = "ColdFusion" },
                new Language { Id = "css", Description = "CSS" },
                new Language { Id = "delphi", Description = "Delphi/Pascal" },
                new Language { Id = "diff", Description = "Diff" },
                new Language { Id = "erl", Description = "Erlang" },
                new Language { Id = "groovy", Description = "Groovy" },
                new Language { Id = "java", Description = "Java" },
                new Language { Id = "jfx", Description = "JavaFX" },
                new Language { Id = "js", Description = "JavaScript" },
                new Language { Id = "lua", Description = "Lua" },
                new Language { Id = "pl", Description = "Perl" },
                new Language { Id = "php", Description = "PHP" },
                new Language { Id = "text", Description = "Plain Text" },
                new Language { Id = "py", Description = "Python" },
                new Language { Id = "rb", Description = "Ruby" },
                new Language { Id = "sass", Description = "SASS" },
                new Language { Id = "scala", Description = "Scala" },
                new Language { Id = "sql", Description = "SQL" },
                new Language { Id = "vb", Description = "Visual Basic" },
                new Language { Id = "xml", Description = "XML" }
            );
        }
    }
}
