﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.arm
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Сотрудник.
    /// </summary>
    // *** Start programmer edit section *** (Сотрудник CustomAttributes)

    // *** End programmer edit section *** (Сотрудник CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СотрудникE", new string[] {
            "номер as \'Номер\'",
            "фамилия as \'Фамилия\'",
            "имя as \'Имя\'",
            "отчество as \'Отчество\'",
            "телефон as \'Телефон\'",
            "EMail as \'E mail\'"})]
    [View("СотрудникL", new string[] {
            "номер as \'Номер\'",
            "фамилия as \'Фамилия\'",
            "имя as \'Имя\'",
            "отчество as \'Отчество\'",
            "телефон as \'Телефон\'",
            "EMail as \'E mail\'"})]
    public class Сотрудник : ICSSoft.STORMNET.DataObject
    {
        
        private int fномер;
        
        private string fфамилия;
        
        private string fимя;
        
        private string fотчество;
        
        private string fтелефон;
        
        private string fEMail;
        
        // *** Start programmer edit section *** (Сотрудник CustomMembers)

        // *** End programmer edit section *** (Сотрудник CustomMembers)

        
        /// <summary>
        /// номер.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.номер CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.номер CustomAttributes)
        public virtual int номер
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.номер Get start)

                // *** End programmer edit section *** (Сотрудник.номер Get start)
                int result = this.fномер;
                // *** Start programmer edit section *** (Сотрудник.номер Get end)

                // *** End programmer edit section *** (Сотрудник.номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.номер Set start)

                // *** End programmer edit section *** (Сотрудник.номер Set start)
                this.fномер = value;
                // *** Start programmer edit section *** (Сотрудник.номер Set end)

                // *** End programmer edit section *** (Сотрудник.номер Set end)
            }
        }
        
        /// <summary>
        /// фамилия.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.фамилия CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.фамилия CustomAttributes)
        [StrLen(255)]
        public virtual string фамилия
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.фамилия Get start)

                // *** End programmer edit section *** (Сотрудник.фамилия Get start)
                string result = this.fфамилия;
                // *** Start programmer edit section *** (Сотрудник.фамилия Get end)

                // *** End programmer edit section *** (Сотрудник.фамилия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.фамилия Set start)

                // *** End programmer edit section *** (Сотрудник.фамилия Set start)
                this.fфамилия = value;
                // *** Start programmer edit section *** (Сотрудник.фамилия Set end)

                // *** End programmer edit section *** (Сотрудник.фамилия Set end)
            }
        }
        
        /// <summary>
        /// имя.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.имя CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.имя CustomAttributes)
        [StrLen(255)]
        public virtual string имя
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.имя Get start)

                // *** End programmer edit section *** (Сотрудник.имя Get start)
                string result = this.fимя;
                // *** Start programmer edit section *** (Сотрудник.имя Get end)

                // *** End programmer edit section *** (Сотрудник.имя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.имя Set start)

                // *** End programmer edit section *** (Сотрудник.имя Set start)
                this.fимя = value;
                // *** Start programmer edit section *** (Сотрудник.имя Set end)

                // *** End programmer edit section *** (Сотрудник.имя Set end)
            }
        }
        
        /// <summary>
        /// отчество.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.отчество CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.отчество CustomAttributes)
        [StrLen(255)]
        public virtual string отчество
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.отчество Get start)

                // *** End programmer edit section *** (Сотрудник.отчество Get start)
                string result = this.fотчество;
                // *** Start programmer edit section *** (Сотрудник.отчество Get end)

                // *** End programmer edit section *** (Сотрудник.отчество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.отчество Set start)

                // *** End programmer edit section *** (Сотрудник.отчество Set start)
                this.fотчество = value;
                // *** Start programmer edit section *** (Сотрудник.отчество Set end)

                // *** End programmer edit section *** (Сотрудник.отчество Set end)
            }
        }
        
        /// <summary>
        /// телефон.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.телефон CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.телефон CustomAttributes)
        [StrLen(255)]
        public virtual string телефон
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.телефон Get start)

                // *** End programmer edit section *** (Сотрудник.телефон Get start)
                string result = this.fтелефон;
                // *** Start programmer edit section *** (Сотрудник.телефон Get end)

                // *** End programmer edit section *** (Сотрудник.телефон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.телефон Set start)

                // *** End programmer edit section *** (Сотрудник.телефон Set start)
                this.fтелефон = value;
                // *** Start programmer edit section *** (Сотрудник.телефон Set end)

                // *** End programmer edit section *** (Сотрудник.телефон Set end)
            }
        }
        
        /// <summary>
        /// EMail.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.EMail CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.EMail CustomAttributes)
        [StrLen(255)]
        public virtual string EMail
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.EMail Get start)

                // *** End programmer edit section *** (Сотрудник.EMail Get start)
                string result = this.fEMail;
                // *** Start programmer edit section *** (Сотрудник.EMail Get end)

                // *** End programmer edit section *** (Сотрудник.EMail Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.EMail Set start)

                // *** End programmer edit section *** (Сотрудник.EMail Set start)
                this.fEMail = value;
                // *** Start programmer edit section *** (Сотрудник.EMail Set end)

                // *** End programmer edit section *** (Сотрудник.EMail Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СотрудникE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникE", typeof(IIS.arm.Сотрудник));
                }
            }
            
            /// <summary>
            /// "СотрудникL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникL", typeof(IIS.arm.Сотрудник));
                }
            }
        }
    }
}
