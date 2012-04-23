using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.ExcelApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Worksheet_SelectionChangeEventHandler(NetOffice.ExcelApi.Range Target);
	public delegate void Worksheet_BeforeDoubleClickEventHandler(NetOffice.ExcelApi.Range Target, ref bool Cancel);
	public delegate void Worksheet_BeforeRightClickEventHandler(NetOffice.ExcelApi.Range Target, ref bool Cancel);
	public delegate void Worksheet_ActivateEventHandler();
	public delegate void Worksheet_DeactivateEventHandler();
	public delegate void Worksheet_CalculateEventHandler();
	public delegate void Worksheet_ChangeEventHandler(NetOffice.ExcelApi.Range Target);
	public delegate void Worksheet_FollowHyperlinkEventHandler(NetOffice.ExcelApi.Hyperlink Target);
	public delegate void Worksheet_PivotTableUpdateEventHandler(NetOffice.ExcelApi.PivotTable Target);
	public delegate void Worksheet_PivotTableAfterValueChangeEventHandler(NetOffice.ExcelApi.PivotTable TargetPivotTable, NetOffice.ExcelApi.Range TargetRange);
	public delegate void Worksheet_PivotTableBeforeAllocateChangesEventHandler(NetOffice.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd, ref bool Cancel);
	public delegate void Worksheet_PivotTableBeforeCommitChangesEventHandler(NetOffice.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd, ref bool Cancel);
	public delegate void Worksheet_PivotTableBeforeDiscardChangesEventHandler(NetOffice.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd);
	public delegate void Worksheet_PivotTableChangeSyncEventHandler(NetOffice.ExcelApi.PivotTable Target);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Worksheet 
	/// SupportByVersion Excel, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Worksheet : _Worksheet,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		DocEvents_SinkHelper _docEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Worksheet);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Worksheet(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Worksheet(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Worksheet(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Worksheet 
        /// </summary>		
		public Worksheet():base("Excel.Worksheet")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Worksheet
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Worksheet(string progId):base(progId)
		{
			
		}

		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Excel, 9,10,11,12,14
		/// </summary>
		private event Worksheet_SelectionChangeEventHandler _SelectionChangeEvent;

		/// <summary>
		/// SupportByVersion Excel 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14)]
		public event Worksheet_SelectionChangeEventHandler SelectionChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SelectionChangeEvent += value;
			}
			remove
			{
				_SelectionChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 9,10,11,12,14
		/// </summary>
		private event Worksheet_BeforeDoubleClickEventHandler _BeforeDoubleClickEvent;

		/// <summary>
		/// SupportByVersion Excel 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14)]
		public event Worksheet_BeforeDoubleClickEventHandler BeforeDoubleClickEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDoubleClickEvent += value;
			}
			remove
			{
				_BeforeDoubleClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 9,10,11,12,14
		/// </summary>
		private event Worksheet_BeforeRightClickEventHandler _BeforeRightClickEvent;

		/// <summary>
		/// SupportByVersion Excel 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14)]
		public event Worksheet_BeforeRightClickEventHandler BeforeRightClickEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeRightClickEvent += value;
			}
			remove
			{
				_BeforeRightClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 9,10,11,12,14
		/// </summary>
		private event Worksheet_ActivateEventHandler _ActivateEvent;

		/// <summary>
		/// SupportByVersion Excel 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14)]
		public event Worksheet_ActivateEventHandler ActivateEvent
		{
			add
			{
				CreateEventBridge();
				_ActivateEvent += value;
			}
			remove
			{
				_ActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 9,10,11,12,14
		/// </summary>
		private event Worksheet_DeactivateEventHandler _DeactivateEvent;

		/// <summary>
		/// SupportByVersion Excel 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14)]
		public event Worksheet_DeactivateEventHandler DeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_DeactivateEvent += value;
			}
			remove
			{
				_DeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 9,10,11,12,14
		/// </summary>
		private event Worksheet_CalculateEventHandler _CalculateEvent;

		/// <summary>
		/// SupportByVersion Excel 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14)]
		public event Worksheet_CalculateEventHandler CalculateEvent
		{
			add
			{
				CreateEventBridge();
				_CalculateEvent += value;
			}
			remove
			{
				_CalculateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 9,10,11,12,14
		/// </summary>
		private event Worksheet_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByVersion Excel 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14)]
		public event Worksheet_ChangeEventHandler ChangeEvent
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
		/// SupportByVersion Excel, 9,10,11,12,14
		/// </summary>
		private event Worksheet_FollowHyperlinkEventHandler _FollowHyperlinkEvent;

		/// <summary>
		/// SupportByVersion Excel 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14)]
		public event Worksheet_FollowHyperlinkEventHandler FollowHyperlinkEvent
		{
			add
			{
				CreateEventBridge();
				_FollowHyperlinkEvent += value;
			}
			remove
			{
				_FollowHyperlinkEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 10,11,12,14
		/// </summary>
		private event Worksheet_PivotTableUpdateEventHandler _PivotTableUpdateEvent;

		/// <summary>
		/// SupportByVersion Excel 10 11 12 14
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14)]
		public event Worksheet_PivotTableUpdateEventHandler PivotTableUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableUpdateEvent += value;
			}
			remove
			{
				_PivotTableUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 14
		/// </summary>
		private event Worksheet_PivotTableAfterValueChangeEventHandler _PivotTableAfterValueChangeEvent;

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		[SupportByVersion("Excel", 14)]
		public event Worksheet_PivotTableAfterValueChangeEventHandler PivotTableAfterValueChangeEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableAfterValueChangeEvent += value;
			}
			remove
			{
				_PivotTableAfterValueChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 14
		/// </summary>
		private event Worksheet_PivotTableBeforeAllocateChangesEventHandler _PivotTableBeforeAllocateChangesEvent;

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		[SupportByVersion("Excel", 14)]
		public event Worksheet_PivotTableBeforeAllocateChangesEventHandler PivotTableBeforeAllocateChangesEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableBeforeAllocateChangesEvent += value;
			}
			remove
			{
				_PivotTableBeforeAllocateChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 14
		/// </summary>
		private event Worksheet_PivotTableBeforeCommitChangesEventHandler _PivotTableBeforeCommitChangesEvent;

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		[SupportByVersion("Excel", 14)]
		public event Worksheet_PivotTableBeforeCommitChangesEventHandler PivotTableBeforeCommitChangesEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableBeforeCommitChangesEvent += value;
			}
			remove
			{
				_PivotTableBeforeCommitChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 14
		/// </summary>
		private event Worksheet_PivotTableBeforeDiscardChangesEventHandler _PivotTableBeforeDiscardChangesEvent;

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		[SupportByVersion("Excel", 14)]
		public event Worksheet_PivotTableBeforeDiscardChangesEventHandler PivotTableBeforeDiscardChangesEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableBeforeDiscardChangesEvent += value;
			}
			remove
			{
				_PivotTableBeforeDiscardChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Excel, 14
		/// </summary>
		private event Worksheet_PivotTableChangeSyncEventHandler _PivotTableChangeSyncEvent;

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		[SupportByVersion("Excel", 14)]
		public event Worksheet_PivotTableChangeSyncEventHandler PivotTableChangeSyncEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableChangeSyncEvent += value;
			}
			remove
			{
				_PivotTableChangeSyncEvent -= value;
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, DocEvents_SinkHelper.Id);


			if(DocEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_docEvents_SinkHelper = new DocEvents_SinkHelper(this, _connectPoint);
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
			if( null != _docEvents_SinkHelper)
			{
				_docEvents_SinkHelper.Dispose();
				_docEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}