using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickCompileHelper.CompilerServices.CompilerElements
{
    /// <summary>
    /// <see cref="TReferenceAssemblyInfo"/> のコレクションを定義します．
    /// </summary>
    /// <typeparam name="TFrameworkInfo"></typeparam>
    /// <typeparam name="TReferenceAssemblyInfo"></typeparam>
    public class ReferenceAssemblyCollection<TFrameworkInfo, TReferenceAssemblyInfo> : ICollection<TReferenceAssemblyInfo>
        where TFrameworkInfo : IFrameworkInfo
        where TReferenceAssemblyInfo : IReferenceAssemblyInfo<TFrameworkInfo>
    {
        // 非公開フィールド
        private List<TReferenceAssemblyInfo> referenceAssemblies;


        // 公開プロパティ

        /// <summary>
        /// 指定したインデックスにある要素を取得または設定します。
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public virtual TReferenceAssemblyInfo this[int i]
        {
            get => this.referenceAssemblies[i];
        }

        /// <summary>
        /// このコレクションに格納されている要素の数を取得します。
        /// </summary>
        public virtual int Count
        {
            get => this.referenceAssemblies.Count;
        }

        /// <summary>
        /// 読み取り専用かどうかを示す値を取得します．
        /// </summary>
        public virtual bool IsReadOnly
        {
            get => ((ICollection<TReferenceAssemblyInfo>)this.referenceAssemblies).IsReadOnly;
        }


        // コンストラクタ

        /// <summary>
        /// 指定したコレクションからコピーした要素を格納し，コピーされる要素の数を格納できるだけの容量を備えた， ReferenceAssemblyCollection クラスの新しいインスタンスを初期化します．
        /// </summary>
        /// <param name="collection"></param>
        public ReferenceAssemblyCollection(IEnumerable<TReferenceAssemblyInfo> collection)
        {
            this.referenceAssemblies = new List<TReferenceAssemblyInfo>(collection);
        }

        /// <summary>
        /// 新しい ReferenceAssemblyCollection クラスのインスタンスを初期化します．
        /// </summary>
        public ReferenceAssemblyCollection()
            : this(new TReferenceAssemblyInfo[0])
        {
        }


        // 公開メソッド

        /// <summary>
        /// コレクションの末尾に <see cref="TReferenceAssemblyInfo"/> のインスタンスへの参照を追加します．
        /// </summary>
        /// <param name="item"></param>
        public void Add(TReferenceAssemblyInfo item)
        {
            this.referenceAssemblies.Add(item);
        }

        /// <summary>
        /// 指定した <see cref="TReferenceAssemblyInfo"/> のコレクションを末尾に追加します．
        /// </summary>
        /// <param name="collection"></param>
        public void AddRange(IEnumerable<TReferenceAssemblyInfo> collection)
        {
            this.referenceAssemblies.AddRange(collection);
        }

        /// <summary>
        /// コレクションからすべての要素を削除します．
        /// </summary>
        public void Clear()
        {
            this.referenceAssemblies.Clear();
        }

        /// <summary>
        /// 指定した <see cref="TReferenceAssemblyInfo"/> のインスタンスへの参照が現在のコレクションに含まれているかを判断します．
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(TReferenceAssemblyInfo item)
        {
            return this.referenceAssemblies.Contains(item);
        }

        /// <summary>
        /// コレクション全体を，<see cref="TReferenceAssemblyInfo"/> の1次配列の指定したインデックスから始まる位置にコピーします．
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(TReferenceAssemblyInfo[] array, int arrayIndex)
        {
            this.referenceAssemblies.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// 特定のオブジェクトで最初に出現したものを現在のコレクションから削除します。
        /// </summary>
        /// <param name="item">item が正常に削除された場合は true。それ以外の場合は false。</param>
        /// <returns></returns>
        public bool Remove(TReferenceAssemblyInfo item)
        {
            return this.referenceAssemblies.Remove(item);
        }

        /// <summary>
        /// 反復処理する列挙子を返します。
        /// </summary>
        /// <returns></returns>
        public IEnumerator<TReferenceAssemblyInfo> GetEnumerator()
        {
            return this.referenceAssemblies.GetEnumerator();
        }


        // 公開メソッド :: インターフェイスの明示的な実装

        /// <summary>
        /// 反復処理する列挙子を返します。
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this.referenceAssemblies).GetEnumerator();
        }
    }
}
