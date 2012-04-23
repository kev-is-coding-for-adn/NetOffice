using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.MSHTMLApi
{
	///<summary>
	/// DispatchInterface IHTMLWindow3 
	/// SupportByVersion MSHTML, 4
	///</summary>
	[SupportByVersionAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IHTMLWindow3 : COMObject
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
                    _type = typeof(IHTMLWindow3);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow3(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow3(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow3(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow3() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow3(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public Int32 screenLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "screenLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public Int32 screenTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "screenTop", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object onbeforeprint
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onbeforeprint", paramsArray);
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
				Invoker.PropertySet(this, "onbeforeprint", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object onafterprint
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onafterprint", paramsArray);
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
				Invoker.PropertySet(this, "onafterprint", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDataTransfer clipboardData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "clipboardData", paramsArray);
				NetOffice.MSHTMLApi.IHTMLDataTransfer newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSHTMLApi.IHTMLDataTransfer.LateBindingApiWrapperType) as NetOffice.MSHTMLApi.IHTMLDataTransfer;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="_event">string event</param>
		/// <param name="pdisp">object pdisp</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public bool attachEvent(string _event, object pdisp)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_event, pdisp);
			object returnItem = Invoker.MethodReturn(this, "attachEvent", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="_event">string event</param>
		/// <param name="pdisp">object pdisp</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void detachEvent(string _event, object pdisp)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_event, pdisp);
			Invoker.Method(this, "detachEvent", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">object expression</param>
		/// <param name="msec">Int32 msec</param>
		/// <param name="language">optional object language</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public Int32 setTimeout(object expression, Int32 msec, object language)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec, language);
			object returnItem = Invoker.MethodReturn(this, "setTimeout", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">object expression</param>
		/// <param name="msec">Int32 msec</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public Int32 setTimeout(object expression, Int32 msec)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec);
			object returnItem = Invoker.MethodReturn(this, "setTimeout", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">object expression</param>
		/// <param name="msec">Int32 msec</param>
		/// <param name="language">optional object language</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public Int32 setInterval(object expression, Int32 msec, object language)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec, language);
			object returnItem = Invoker.MethodReturn(this, "setInterval", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">object expression</param>
		/// <param name="msec">Int32 msec</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public Int32 setInterval(object expression, Int32 msec)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec);
			object returnItem = Invoker.MethodReturn(this, "setInterval", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void print()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "print", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="varArgIn">optional object varArgIn</param>
		/// <param name="options">optional object options</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 showModelessDialog(string url, object varArgIn, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url, varArgIn, options);
			object returnItem = Invoker.MethodReturn(this, "showModelessDialog", paramsArray);
			NetOffice.MSHTMLApi.IHTMLWindow2 newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 showModelessDialog()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "showModelessDialog", paramsArray);
			NetOffice.MSHTMLApi.IHTMLWindow2 newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 showModelessDialog(string url)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url);
			object returnItem = Invoker.MethodReturn(this, "showModelessDialog", paramsArray);
			NetOffice.MSHTMLApi.IHTMLWindow2 newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="varArgIn">optional object varArgIn</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 showModelessDialog(string url, object varArgIn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url, varArgIn);
			object returnItem = Invoker.MethodReturn(this, "showModelessDialog", paramsArray);
			NetOffice.MSHTMLApi.IHTMLWindow2 newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}