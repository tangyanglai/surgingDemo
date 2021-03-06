
using MicroService.Core;
using MicroService.Data.Common;
using MicroService.Data.Enums;
using MicroService.Common.Models;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text;

 namespace MicroService.IApplication.Order.Dto
 {
	/// <summary>
	/// OrderInfos --dto
	/// </summary>
    [ProtoContract]
    [Serializable]
	public class OrderInfosRequestDto:LoginUser
	{

		//<summary>
		// 订单号
		//<summary>
		public string OrderNumber { set; get; }

		//<summary>
		// 总金额
		//<summary>
		public decimal TotalMoney { set; get; }

		//<summary>
		// 下单用户
		//<summary>
		public string UserId { set; get; }

		//<summary>
		// 过期时间
		//<summary>
		public DateTime ExpireTime { set; get; }

		//<summary>
		// 订单状态
		//<summary>
		public int Status { set; get; }
 
	}
}