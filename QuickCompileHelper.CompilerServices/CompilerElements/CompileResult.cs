using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickCompileHelper.CompilerServices.CompilerElements
{
    /// <summary>
    /// コンパイル結果を格納します．
    /// </summary>
    /// <typeparam name="TCompiler"></typeparam>
    /// <typeparam name="TFrameworkInfo"></typeparam>
    /// <typeparam name="TCompilerInfo"></typeparam>
    public class CompileResult<TCompiler, TFrameworkInfo, TCompilerInfo>
        where TCompiler : ICompiler<TFrameworkInfo, TCompilerInfo>
        where TFrameworkInfo : IFrameworkInfo
        where TCompilerInfo : ICompilerInfo<TFrameworkInfo>
    {
        // 非公開フィールド
        private string outputFile;
        private TargetLineInfo[] warningLines;
        private TargetLineInfo[] errorLines;


        // 公開プロパティ

        /// <summary>
        /// 出力されたファイルを取得します．
        /// 出力されていない場合や，取得に失敗している場合は，nullを示します．
        /// </summary>
        public string OutputFile
        {
            get => this.outputFile;
        }

        /// <summary>
        /// 警告箇所が発生したかどうかを示す真偽値を取得します．
        /// </summary>
        public bool HasWarning
        {
            get => this.warningLines.Length != 0;
        }

        /// <summary>
        /// コンパイルが成功したかどうかを示す真偽値を取得します．
        /// </summary>
        public bool IsSuccess
        {
            get => this.errorLines.Length == 0;
        }

        /// <summary>
        /// 警告箇所を表す <see cref="TargetLineInfo"/> のコレクションを取得します．
        /// </summary>
        public IEnumerable<TargetLineInfo> WarningLines
        {
            get => this.warningLines;
        }

        /// <summary>
        /// エラー箇所を表す <see cref="TargetLineInfo"/> のコレクションを取得します．
        /// </summary>
        public IEnumerable<TargetLineInfo> ErrorLines
        {
            get => this.errorLines;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい <see cref="CompileResult{TCompiler, TFrameworkInfo, TCompilerInfo}"/> クラスのインスタンスを初期化します．
        /// </summary>
        /// <param name="outputFile">出力されたファイルのパス</param>
        /// <param name="warningLines">警告発生個所の情報のコレクション</param>
        /// <param name="errorLines">エラー発生個所の情報のコレクション</param>
        public CompileResult(string outputFile, IEnumerable<TargetLineInfo> warningLines, IEnumerable<TargetLineInfo> errorLines)
        {
            this.outputFile = outputFile;
            this.warningLines = warningLines.ToArray();
            this.errorLines = errorLines.ToArray();
        }

        /// <summary>
        /// 正常に出力が行われたことを前提として，新しい <see cref="CompileResult{TCompiler, TFrameworkInfo, TCompilerInfo}"/> クラスのインスタンスを初期化します．
        /// </summary>
        /// <param name="outputFile"></param>
        public CompileResult(string outputFile)
            : this(outputFile, new TargetLineInfo[0], new TargetLineInfo[0])
        {
            // 実装なし
        }
    }
}
