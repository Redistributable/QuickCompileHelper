using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickCompileHelper.CompilerServices
{
    /// <summary>
    /// 
    /// </summary>
    public interface IReferenceAssemblyInfo<TFramework>
        where TFramework : IFrameworkInfo
    {
        // プロパティ

        /// <summary>
        /// アセンブリの名前を取得します．
        /// </summary>
        string Name { get; }

        /// <summary>
        /// アセンブリの場所を表すパスを取得します．
        /// </summary>
        string Path { get; }
        

    }
}
