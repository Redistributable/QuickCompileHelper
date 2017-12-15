using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QuickCompileHelper.CompilerServices.CompilerElements;

namespace QuickCompileHelper.CompilerServices
{
    /// <summary>
    /// コンパイルを実行するクラスを定義します。
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

        /// <summary>
        /// コンパイル時に参照する <see cref="IReferenceAssemblyInfo{TFrameworkInfo}"/> のコレクションを取得します．
        /// </summary>
        ReferenceAssemblyCollection<TFrameworkInfo, IReferenceAssemblyInfo<TFrameworkInfo>> ReferenceAssemblies
        {
            get;
        }




        // メソッド

        /// <summary>
        /// 現在の設定で，コンパイルを実行します．
        /// このメソッドは，インターフェイスの明示的な実装で定義されることが推奨されます．
        /// </summary>
        /// <returns></returns>
        CompileResult<ICompiler<TFrameworkInfo, TCompilerInfo>, TFrameworkInfo, TCompilerInfo> Compile();
    }
}
