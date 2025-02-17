// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.Web.CodeGeneration
{
    //Review: This has both templating based helper methods and non-templating based helpers,
    //perhaps separate into two interfaces?
    public interface ICodeGeneratorActionsService
    {
        Task AddFileFromTemplateAsync(string outputPath, string templateName, IEnumerable<string> templateFolders, object templateModel);

        Task AddFileAsync(string outputPath, string sourceFilePath);

        /// <summary>
        /// Execute RazorTemplate and return the resulting code in a string. Used to inject into classes using CodeAnalysis
        /// </summary>
        /// <param name="templateName"> name of template in Templates folder (src\VS.Web.CG.Mvc/Templates)</param>
        /// <param name="templateFolders">which folders to check</param>
        /// <param name="templateModel">template model for injecting variable metadata</param>
        /// <returns></returns>
        Task<string> ExecuteTemplate(string templateName, IEnumerable<string> templateFolders, object templateModel);
    }
}
