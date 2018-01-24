using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Serializable()]
    [System.ComponentModel.DataAnnotations.Schema.Table("CUSTOMER")]
    public class Customer
    {
        [Key]
        /// <summary>
        ///编号
        /// </summary>
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        ///登录手机号
        /// </summary>
        public string CELLPHONENUMBER
        {
            get;
            set;
        }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string PASSWORD
        {
            get;
            set;
        }

        /// <summary>
        ///姓名
        /// </summary>
        public string NAME
        {
            get;
            set;
        }

        /// <summary>
        ///创建时间
        /// </summary>
        public DateTime CREATEDTIME
        {
            get;
            set;
        }

        /// <summary>
        /// 未认证 0
        ///已认证，未审核 1
        ///已审核，已通过 2
        ///已审核，未通过 3
        /// </summary>
        public int CERTIFICATIONSTATUS
        {
            get;
            set;
        }

        /// <summary>
        ///推荐人
        /// </summary>
        public string REFERRERNUMBER
        {
            get;
            set;
        }

        /// <summary>
        ///证件类型
        /// </summary>
        public int CARDTYPE
        {
            get;
            set;
        }

        /// <summary>
        ///身份证号
        /// </summary>
        public string IDCARDNUMBER
        {
            get;
            set;
        }

        /// <summary>
        ///身份证照片名
        /// </summary>
        public string IDCARDPHOTO
        {
            get;
            set;
        }

        /// <summary>
        ///身份证照片URL地址
        /// </summary>
        public string IDCARDPHOTOURL
        {
            get;
            set;
        }

        /// <summary>
        ///性别
        /// </summary>
        public int? GENDER
        {
            get;
            set;
        }

        /// <summary>
        ///昵称
        /// </summary>
        public string NICKNAME
        {
            get;
            set;
        }

        /// <summary>
        ///生日
        /// </summary>
        public DateTime? BIRTHDAY
        {
            get;
            set;
        }

        /// <summary>
        ///省份代码
        /// </summary>
        public string PROVINCECODE
        {
            get;
            set;
        }

        /// <summary>
        /// 省份名称
        /// </summary>
        public string PROVINCENAME
        {
            get;
            set;
        }
        /// <summary>
        ///城市代码
        /// </summary>
        public string CITYCODE
        {
            get;
            set;
        }
        /// <summary>
        /// 城市名称
        /// </summary>
        public string CITYNAME
        {
            get;
            set;
        }
        /// <summary>
        ///头像URL
        /// </summary>
        public string PORTRAITURL
        {
            get;
            set;
        }

        /// <summary>
        ///头像名称
        /// </summary>
        public string PORTRAITNAME
        {
            get;
            set;
        }

        /// <summary>
        ///是否可用
        /// </summary>
        public int ENABLE
        {
            get;
            set;
        }

        /// <summary>
        ///在线状态: 0 不在线, 1 在线
        /// </summary>
        public int ONLINESTATUS
        {
            get;
            set;
        }

        /// <summary>
        /// 登录后生成的令牌
        /// </summary>
        public string TOKEN
        {
            get;
            set;
        }

        /// <summary>
        /// 是否是商户, 该字段暂不用
        /// </summary>
        public int ISMERCHANT
        {
            get;
            set;
        }


        /// <summary>
        /// 微信openid, 微信公众平台注册需要发送该字段
        /// </summary>
        public string WEBCHATOPENID
        {
            get;
            set;
        }

        /// <summary>
        ///推荐商户的手机号,可为空
        /// </summary>
        public string REFERRERMERCHANT
        {
            get;
            set;
        }

        /// <summary>
        /// 用户的类型: 0 Le助手用户; 1 轩辕通用户
        /// </summary>
        public int CUSTOMERTYPE
        {
            get;
            set;
        }

        /// <summary>
        /// 实名状态 0 未认证 1 已认证
        /// </summary>
        public int? REALNAMESTATUS
        {
            get;
            set;
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string REALNAME
        {
            get;
            set;
        }
        /// <summary>
        ///  实名身份证号
        /// </summary>
        public string REALNAMEID
        {
            get;
            set;
        }
        /// <summary>
        ///  角色
        /// </summary>
        public string ROLE
        {
            get;
            set;
        }
    }
}
