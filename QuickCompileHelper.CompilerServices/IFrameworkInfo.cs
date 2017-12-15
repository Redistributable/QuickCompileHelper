using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickCompileHelper.CompilerServices
{
    /// <summary>
    /// フレームワークに関する情報を保持します．
    /// </summary>
    public interface IFrameworkInfo
    {
        // プロパティ

        /// <summary>
        /// フレームワークの名前を取得します．
        /// </summary>
        string FrameworkName
        {
            get;
        }


        // 公開メソッド

        /// <summary>
        /// 現在の環境で有効かどうかを確認します．
        /// </summary>
        /// <returns></returns>
        bool CheckAvailable();

        /// <summary>
        /// 利用可能なコンパイラを取得します．
        /// </summary>
        /// <returns></returns>
        ICompilerInfo<IFrameworkInfo> GetCompilers();

        /// <summary>
        /// 利用可能な標準参照アセンブリを取得します．
        /// </summary>
        /// <returns></returns>
        IReferenceAssemblyInfo<IFrameworkInfo>[] GetStandardAssemblies();
    }
}
