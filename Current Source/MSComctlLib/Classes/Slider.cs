using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.MSComctlLibApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Slider_ClickEventHandler();
	public delegate void Slider_KeyDownEventHandler(ref Int16 KeyCode, Int16 Shift);
	public delegate void Slider_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void Slider_KeyUpEventHandler(ref Int16 KeyCode, Int16 Shift);
	public delegate void Slider_MouseDownEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void Slider_MouseMoveEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void Slider_MouseUpEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void Slider_ScrollEventHandler();
	public delegate void Slider_ChangeEventHandler();
	public delegate void Slider_OLEStartDragEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 AllowedEffects);
	public delegate void Slider_OLEGiveFeedbackEventHandler(ref Int32 Effect, ref bool DefaultCursors);
	public delegate void Slider_OLESetDataEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int16 DataFormat);
	public delegate void Slider_OLECompleteDragEventHandler(ref Int32 Effect);
	public delegate void Slider_OLEDragOverEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y, ref Int16 State);
	public delegate void Slider_OLEDragDropEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Slider 
	/// SupportByVersion MSComctlLib, 6.0
	///</summary>
	[SupportByVersionAttribute("MSComctlLib", 6.0)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Slider : ISlider,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ISliderEvents_SinkHelper _iSliderEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Slider);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Slider(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Slider(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Slider(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Slider 
        /// </summary>		
		public Slider():base("MSComctlLib.Slider")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Slider
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Slider(string progId):base(progId)
		{
			
		}

		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_ScrollEventHandler _ScrollEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_ScrollEventHandler ScrollEvent
		{
			add
			{
				CreateEventBridge();
				_ScrollEvent += value;
			}
			remove
			{
				_ScrollEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_ChangeEventHandler ChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ChangeEvent += value;
			}
			remove
			{
				_ChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_OLEStartDragEventHandler _OLEStartDragEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_OLEStartDragEventHandler OLEStartDragEvent
		{
			add
			{
				CreateEventBridge();
				_OLEStartDragEvent += value;
			}
			remove
			{
				_OLEStartDragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_OLEGiveFeedbackEventHandler _OLEGiveFeedbackEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_OLEGiveFeedbackEventHandler OLEGiveFeedbackEvent
		{
			add
			{
				CreateEventBridge();
				_OLEGiveFeedbackEvent += value;
			}
			remove
			{
				_OLEGiveFeedbackEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_OLESetDataEventHandler _OLESetDataEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_OLESetDataEventHandler OLESetDataEvent
		{
			add
			{
				CreateEventBridge();
				_OLESetDataEvent += value;
			}
			remove
			{
				_OLESetDataEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_OLECompleteDragEventHandler _OLECompleteDragEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_OLECompleteDragEventHandler OLECompleteDragEvent
		{
			add
			{
				CreateEventBridge();
				_OLECompleteDragEvent += value;
			}
			remove
			{
				_OLECompleteDragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_OLEDragOverEventHandler _OLEDragOverEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_OLEDragOverEventHandler OLEDragOverEvent
		{
			add
			{
				CreateEventBridge();
				_OLEDragOverEvent += value;
			}
			remove
			{
				_OLEDragOverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib, 6.0
		/// </summary>
		private event Slider_OLEDragDropEventHandler _OLEDragDropEvent;

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// </summary>
		[SupportByVersion("MSComctlLib", 6.0)]
		public event Slider_OLEDragDropEventHandler OLEDragDropEvent
		{
			add
			{
				CreateEventBridge();
				_OLEDragDropEvent += value;
			}
			remove
			{
				_OLEDragDropEvent -= value;
			}
		}

		#endregion
       
	    #region IEventBinding Member
        
		/// <summary>
        /// creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == NetOffice.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ISliderEvents_SinkHelper.Id);


			if(ISliderEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_iSliderEvents_SinkHelper = new ISliderEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
        {
			if(null == _thisType)
				_thisType = this.GetType();
					
			foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
			{
				MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
				if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
					return false;
			}
				
			return false;
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates.Length;
            }
            else
                return 0;
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                foreach (var item in delegates)
                {
                    try
                    {
                        item.Method.Invoke(item.Target, paramsArray);
                    }
                    catch (NetRuntimeSystem.Exception exception)
                    {
                        DebugConsole.WriteException(exception);
                    }
                }
                return delegates.Length;
            }
            else
                return 0;
		}

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != _iSliderEvents_SinkHelper)
			{
				_iSliderEvents_SinkHelper.Dispose();
				_iSliderEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}