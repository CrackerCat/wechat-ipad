using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "StyleKeyVal")]
	[Serializable]
	public class StyleKeyVal : IExtensible
	{
		private uint _Key;

		private string _Val = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Key", DataFormat = DataFormat.TwosComplement)]
		public uint Key
		{
			get
			{
				return this._Key;
			}
			set
			{
				this._Key = value;
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "Val", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Val
		{
			get
			{
				return this._Val;
			}
			set
			{
				this._Val = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
