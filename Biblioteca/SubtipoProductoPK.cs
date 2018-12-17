using System;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
namespace dto.clases
{

	/// 
	/// <summary>
	/// @author Patricio
	/// </summary>
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Embeddable public class SubtipoProductoPK implements java.io.Serializable
	[Serializable]
	public class SubtipoProductoPK
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @Column(name = "subtipo_p") private short subtipoP;
		private short subtipoP;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "tipo_producto_id_tp") private short tipoProductoIdTp;
		private short tipoProductoIdTp;

		public SubtipoProductoPK()
		{
		}

		public SubtipoProductoPK(short subtipoP, short tipoProductoIdTp)
		{
			this.subtipoP = subtipoP;
			this.tipoProductoIdTp = tipoProductoIdTp;
		}

		public virtual short SubtipoP
		{
			get
			{
				return subtipoP;
			}
			set
			{
				this.subtipoP = value;
			}
		}


		public virtual short TipoProductoIdTp
		{
			get
			{
				return tipoProductoIdTp;
			}
			set
			{
				this.tipoProductoIdTp = value;
			}
		}


		public override int GetHashCode()
		{
			int hash = 0;
			hash += (int) subtipoP;
			hash += (int) tipoProductoIdTp;
			return hash;
		}

		public override bool Equals(object @object)
		{
			// TODO: Warning - this method won't work in the case the id fields are not set
			if (!(@object is SubtipoProductoPK))
			{
				return false;
			}
			SubtipoProductoPK other = (SubtipoProductoPK) @object;
			if (this.subtipoP != other.subtipoP)
			{
				return false;
			}
			if (this.tipoProductoIdTp != other.tipoProductoIdTp)
			{
				return false;
			}
			return true;
		}

		public override string ToString()
		{
			return "dto.clases.SubtipoProductoPK[ subtipoP=" + subtipoP + ", tipoProductoIdTp=" + tipoProductoIdTp + " ]";
		}

	}

}