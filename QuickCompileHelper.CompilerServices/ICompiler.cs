using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickCompileHelper.CompilerServices
{
    /// <summary>
    /// hoge
    /// </summary>
    /// <typeparam name="TFrameworkInfo"></typeparam>
    /// <typeparam name="TCompilerInfo"></typeparam>
    public interface ICompiler<TFrameworkInfo, TCompilerInfo>
        where TFrameworkInfo : IFrameworkInfo
        where TCompilerInfo : ICompilerInfo<TFrameworkInfo>
    {
        // プロパティ
        
        /// <summary>
        /// このコンパイラの生成元である <see cref="TCompilerInfo"/> のインスタンスを取得します．
        /// </summary>
        TCompilerInfo CompilerInfo
        {
            get;
        }

        
    }
}
