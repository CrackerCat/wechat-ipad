using ProtoBuf;
using System;

namespace micromsg
{
	[ProtoContract(Name = "GetProfileResponse")]
	[Serializable]
	public class GetProfileResponse : IExtensible
	{
		private BaseResponse _BaseResponse;

		private ModUserInfo _UserInfo;

		private UserInfoExt _UserInfoExt;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseResponse", DataFormat = DataFormat.Default)]
		public BaseResponse BaseResponse
		{
			get
			{
				return this._BaseResponse;
			}
			set
			{
				this._BaseResponse = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "UserInfo", DataFormat = DataFormat.Default)]
		public ModUserInfo UserInfo
		{
			get
			{
				return this._UserInfo;
			}
			set
			{
				this._UserInfo = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "UserInfoExt", DataFormat = DataFormat.Default)]
		public UserInfoExt UserInfoExt
		{
			get
			{
				return this._UserInfoExt;
			}
			set
			{
				this._UserInfoExt = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
