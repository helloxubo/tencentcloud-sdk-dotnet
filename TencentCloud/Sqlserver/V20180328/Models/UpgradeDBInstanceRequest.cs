/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID，形如mssql-j8kv137v
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例升级后内存大小，单位GB，其值不能小于当前实例内存大小
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 实例升级后磁盘大小，单位GB，其值不能小于当前实例磁盘大小
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 是否自动使用代金券，0 - 不使用；1 - 默认使用。取值默认为0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// 代金券ID，目前单个订单只能使用一张代金券
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// 实例升级后的CPU核心数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
        }
    }
}

