using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook {
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

        //グループ
        public List< GroupType >  listgroup{ get; set; }

        //画像
        [System.ComponentModel.DisplayName("画像")]
        public Image Picture { get; set; }

        public enum GroupType {
            家族, 友人, 仕事, その他
        }
    }
}
