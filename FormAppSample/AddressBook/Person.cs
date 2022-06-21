using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook {
    [Serializable]
    public class Person {

        //名前
        [System.ComponentModel.DisplayName("名前")]
        public string Name { get; set; }

        //メールアドレス
        [System.ComponentModel.DisplayName("メールアドレス")]
        public string MailAddress { get; set; }

        //住所
        [System.ComponentModel.DisplayName("住所")]
        public string Address { get; set; }

        //会社
        [System.ComponentModel.DisplayName("会社")]
        public string Company { get; set; }

        //グループ表示
        [System.ComponentModel.DisplayName("グループ")]
        public string Group {
            get {
                string groups = "";
                foreach (GroupType group in listgroup) {
                    groups += "[" + group + "]";
                }
                return groups;
            }
        }
        //グループ
        public List< GroupType >  listgroup{ get; set; }
        //電話番号
        [System.ComponentModel.DisplayName("電話番号")]
        public string TelNumber { get; set; }
        //種別
        [System.ComponentModel.DisplayName("番号種別")]
        public string KindNumber { get; set; }
        //登録日
        [System.ComponentModel.DisplayName("登録日")]
        public DateTime Registration { get; set; }

        //画像
        [System.ComponentModel.DisplayName("画像")]
        public Image Picture { get; set; }

        public enum GroupType {
            家族, 友人, 仕事, その他
        }
        public enum KindNumberType {
            自宅,携帯
        }
    }
}
