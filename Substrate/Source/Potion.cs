using System;
using Substrate.Nbt;
namespace Substrate
{
    public class PotionEffect
    {
        private static readonly SchemaNodeCompound _schema = new SchemaNodeCompound("")
        {
            new SchemaNodeScalar("Id", TagType.TAG_BYTE),
            new SchemaNodeScalar("Amplifier", TagType.TAG_BYTE, SchemaOptions.OPTIONAL),
            new SchemaNodeScalar("Duration", TagType.TAG_INT, SchemaOptions.OPTIONAL),
            new SchemaNodeScalar("Ambient", TagType.TAG_BYTE, SchemaOptions.OPTIONAL),
            new SchemaNodeScalar("ShowParticles", TagType.TAG_BYTE, SchemaOptions.OPTIONAL),
            new SchemaNodeScalar("ShowIcon", TagType.TAG_BYTE, SchemaOptions.OPTIONAL),
        };
        public static SchemaNodeCompound Schema
        {
            get { return _schema; }
        }

        [TagNode(Name = "Id")]
        public byte ID { get; set; }
        [TagNode(Name = "Amplifier")]
        public byte Amplifier { get; set; }
        [TagNode(Name = "Duration")]
        public int Duration { get; set; }
        [TagNode(Name = "Ambient")]
        public byte Ambient { get; set; }
        [TagNode(Name = "ShowParticles")]
        public byte ShowParticles { get; set; }
        [TagNode(Name = "ShowIcon")]
        public byte ShowIcon { get; set; }
    }
}
