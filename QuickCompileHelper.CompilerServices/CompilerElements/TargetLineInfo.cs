using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickCompileHelper.CompilerServices.CompilerElements
{
    /// <summary>
    /// ソースコード中のコンパイラ通知が発生した行に関する情報を格納します．
    /// </summary>
    public struct TargetLineInfo
    {
        // 非公開フィールド
        private uint lineNumber;
        private CompileNoticeInfo[] noticeInfos;


        // 公開プロパティ

        /// <summary>
        /// 行数番号を取得または設定します．
        /// </summary>
        public uint LineNumber
        {
            get => this.lineNumber;
            set => this.lineNumber = value;
        }

        /// <summary>
        /// エラーの詳細情報を表す <see cref="CompileNoticeInfo"/> の1次配列を取得または設定します．
        /// </summary>
        public CompileNoticeInfo[] NoticeInfos
        {
            get => this.noticeInfos;
            set => this.noticeInfos = value;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい TargetLineInfo 構造体のインスタンスを初期化します．
        /// </summary>
        /// <param name="lineNumber"></param>
        /// <param name="noticeInfos"></param>
        public TargetLineInfo(uint lineNumber, CompileNoticeInfo[] noticeInfos)
        {
            this.lineNumber = lineNumber;
            this.noticeInfos = noticeInfos;
        }
    }
}
