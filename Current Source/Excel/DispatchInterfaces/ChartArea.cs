using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface ChartArea 
	/// SupportByVersion Excel, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ChartArea : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ChartArea);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartArea(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartArea(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartArea(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartArea() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartArea(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlCreator)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Border Border
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Border", paramsArray);
				NetOffice.ExcelApi.Border newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Border.LateBindingApiWrapperType) as NetOffice.ExcelApi.Border;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Font Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				NetOffice.ExcelApi.Font newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Font.LateBindingApiWrapperType) as NetOffice.ExcelApi.Font;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public bool Shadow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shadow", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Shadow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public Double Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return NetRuntimeSystem.Convert.ToDouble(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Interior Interior
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Interior", paramsArray);
				NetOffice.ExcelApi.Interior newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Interior.LateBindingApiWrapperType) as NetOffice.ExcelApi.Interior;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.ChartFillFormat Fill
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fill", paramsArray);
				NetOffice.ExcelApi.ChartFillFormat newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ChartFillFormat.LateBindingApiWrapperType) as NetOffice.ExcelApi.ChartFillFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public Double Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return NetRuntimeSystem.Convert.ToDouble(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public Double Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return NetRuntimeSystem.Convert.ToDouble(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public Double Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return NetRuntimeSystem.Convert.ToDouble(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public object AutoScaleFont
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoScaleFont", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoScaleFont", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.ChartFormat Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				NetOffice.ExcelApi.ChartFormat newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ChartFormat.LateBindingApiWrapperType) as NetOffice.ExcelApi.ChartFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
		public bool RoundedCorners
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RoundedCorners", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RoundedCorners", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public object Select()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Select", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public object Clear()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Clear", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public object ClearContents()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ClearContents", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public object Copy()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public object ClearFormats()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ClearFormats", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		#endregion
		#pragma warning restore
	}
}