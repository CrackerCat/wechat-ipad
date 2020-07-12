using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "VerifyVoicePrintRsaRequest")]
	[Serializable]
	public class VerifyVoicePrintRsaRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private VoicePieceCtx _Piece;

		private uint _VoiceTicket;

		private uint _ResId;

		private string _VerifyTicket = "";

		private SKBuiltinBuffer_t _RandomEncryKey;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseRequest", DataFormat = DataFormat.Default)]
		public BaseRequest BaseRequest
		{
			get
			{
				return this._BaseRequest;
			}
			set
			{
				this._BaseRequest = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "Piece", DataFormat = DataFormat.Default)]
		public VoicePieceCtx Piece
		{
			get
			{
				return this._Piece;
			}
			set
			{
				this._Piece = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "VoiceTicket", DataFormat = DataFormat.TwosComplement)]
		public uint VoiceTicket
		{
			get
			{
				return this._VoiceTicket;
			}
			set
			{
				this._VoiceTicket = value;
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "ResId", DataFormat = DataFormat.TwosComplement)]
		public uint ResId
		{
			get
			{
				return this._ResId;
			}
			set
			{
				this._ResId = value;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "VerifyTicket", DataFormat = DataFormat.Default), DefaultValue("")]
		public string VerifyTicket
		{
			get
			{
				return this._VerifyTicket;
			}
			set
			{
				this._VerifyTicket = value;
			}
		}

		[ProtoMember(6, IsRequired = true, Name = "RandomEncryKey", DataFormat = DataFormat.Default)]
		public SKBuiltinBuffer_t RandomEncryKey
		{
			get
			{
				return this._RandomEncryKey;
			}
			set
			{
				this._RandomEncryKey = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
