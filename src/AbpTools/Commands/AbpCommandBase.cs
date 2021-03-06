﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;

namespace AbpTools.Commands
{
    [HelpOption("--help")]
    abstract class AbpCommandBase
    {
        public abstract List<string> CreateArgs();

        protected virtual Task<int> OnExecuteAsync(CommandLineApplication app)
        {
            var args = CreateArgs();

            Console.WriteLine($"Result = {Consts.ParentCommandName} " + ArgumentEscaper.EscapeAndConcatenate(args));
            return Task.FromResult(0);
        }
    }
}
