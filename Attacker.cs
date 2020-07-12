﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;
using InnerSpaceAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Attacker class
	/// </summary>
	public class Attacker : Entity
	{
		#region Constructors
		/// <summary>
		/// Attacker copy constructor
		/// </summary>
		/// <param name="copy"></param>
		public Attacker(LavishScriptObject copy) : base(copy) { }
		#endregion

		#region Members

		private Int64? _id;
		public new Int64 ID
		{
			get
			{
				Tracing.SendCallback("Attacker.ID");

				if (_id == null)
					_id = this.GetInt64("ID");

				return _id.Value;
			}
		}

		private bool? _isCurrentlyAttacking;
		/// <summary>
		/// IsCurrentlyAttacking member
		/// </summary>
		public bool IsCurrentlyAttacking
		{
			get
			{
				if (_isCurrentlyAttacking == null)
					_isCurrentlyAttacking = this.GetBool("IsCurrentlyAttacking");
				return _isCurrentlyAttacking.Value;
			}
		}

		private Jammer _toJammer;
		/// Get the Jammer member of the Attacker object
        public new Jammer ToJammer
        {
            get
            {
                return _toJammer ?? (_toJammer = new Jammer(GetMember("ToJammer")));
            }
        }
		#endregion

		#region Methods
		/// <summary>
		/// GetAttacks method
		/// </summary>
		/// <returns></returns>
		public List<Attack> GetAttacks()
		{
			Tracing.SendCallback("Attacker.GetAttacks");
			return Util.GetListFromMethod<Attack>(this, "GetAttacks", "attack");
		}
		#endregion
	}
}
