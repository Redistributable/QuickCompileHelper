using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickCompileHelper.CompilerServices.CompilerElements
{
    public enum OutputType
    {
        /// <summary>
        /// Windows 8.x ストア アプリの .exe ファイルを作成します。
        /// </summary>
        AppContainerExe,

        /// <summary>
        /// .exe ファイルを作成します。
        /// </summary>
        Exe,

        /// <summary>
        /// モジュールを作成します。
        /// </summary>
        Library,

        Module,

        WinExe,

        WinMdObj,
    }
}
