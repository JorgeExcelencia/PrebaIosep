using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Table_TiposDato
    {
        public string? nchar { get; set; }
        public string? _char { get; set; }
        public string? nvarchar { get; set; }
        public string? varchar { get; set; }
        public string? ntext { get; set; }
        public string? nvarcharmax { get; set; }
        public string? text { get; set; }
        public string? varcharmax { get; set; }
        public DateTime? date { get; set; }
        public DateTime? datetime { get; set; }
        public DateTime? smalldatetime { get; set; }
        public DateTime? datetime2 { get; set; }
        public DateTimeOffset? datetimeoffset { get; set; }
        public TimeSpan? time { get; set; }
        public byte[]? timestamp { get; set; }
        public string? xml { get; set; }
        public byte? tinyint { get; set; }
        public short? smallint { get; set; }
        public int? _int { get; set; }
        public long? bigint { get; set; }
        public byte[]? binary { get; set; }
        public byte[]? varbinarymax { get; set; }
        public bool? bit { get; set; }
        public double? _float { get; set; }
        public float? real { get; set; }
        public decimal? _decimal { get; set; }
        public decimal? numeric { get; set; }
        public decimal? money { get; set; }
        public decimal? smallmoney { get; set; }
        public Guid? uniqueidentifier { get; set; }
        public byte[]? image { get; set; }
        public object? sql_variant { get; set; }
    }
}
