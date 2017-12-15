using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickCompileHelper.CompilerServices.CompilerElements
{
    /// <summary>
    /// コンパイラメッセージの詳細情報について格納します．
    /// </summary>
    public struct CompileNoticeInfo
    {
        // 非公開フィールド
        private string code;
        private string message;


        // 公開プロパティ

        /// <summary>
        /// この通知のエラーコードを取得または設定します．
        /// </summary>
        public string Code
        {
            get => this.code;
            set => this.code = value;
        }

        /// <summary>
        /// 通知の内容を表すメッセージを取得または設定します．
        /// </summary>
        public string Message
        {
            get => this.message;
            set => this.message = value;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい <see cref="CompileNoticeInfo"/> 構造体のインスタンスを初期化します．
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public CompileNoticeInfo(string code, string message)
        {
            this.code = code;
            this.message = message;
        }
    }
}
