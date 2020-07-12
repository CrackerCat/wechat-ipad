using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "ModMsgStatus")]
	[Serializable]
	public class ModMsgStatus : IExtensible
	{
		private int _MsgId;

		private SKBuiltinString_t _FromUserName;

		private SKBuiltinString_t _ToUserName;

		private uint _Status;

		private long _NewMsgId = 0L;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "MsgId", DataFormat = DataFormat.TwosComplement)]
		public int MsgId
		{
			get
			{
				return this._MsgId;
			}
			set
			{
				this._MsgId = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "FromUserName", DataFormat = DataFormat.Default)]
		public SKBuiltinString_t FromUserName
		{
			get
			{
				return this._FromUserName;
			}
			set
			{
				this._FromUserName = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "ToUserName", DataFormat = DataFormat.Default)]
		public SKBuiltinString_t ToUserName
		{
			get
			{
				return this._ToUserName;
			}
			set
			{
				this._ToUserName = value;
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "Status", DataFormat = DataFormat.TwosComplement)]
		public uint Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				this._Status = value;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "NewMsgId", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public long NewMsgId
		{
			get
			{
				return this._NewMsgId;
			}
			set
			{
				this._NewMsgId = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
