using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickCompileHelper.CompilerServices
{
    /// <summary>
    /// コンパイラに関する情報を保持します．
    /// </summary>
    public interface ICompilerInfo<TFramework>
        where TFramework : IFrameworkInfo
    {
        // プロパティ

        /// <summary>
        /// コンパイラの名前を取得します．
        /// </summary>
        string CompilerName
        {
            get;
        }


        // メソッド

        /// <summary>
        /// このコンパイラ情報の発行元である <see cref="TFramework"/> のインスタンスを取得します．
        /// </summary>
        /// <returns></returns>
        IFrameworkInfo GetParentFramework();
    }
}
