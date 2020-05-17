using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace 가계부.Models
{
    public class Trade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// 지출 수입에 대한 값
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// 지출 수입에 대한 사유
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 상세 내역
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 거래가 발생한 시간
        /// </summary>
        public DateTime Date { get; set; }
    }
}
