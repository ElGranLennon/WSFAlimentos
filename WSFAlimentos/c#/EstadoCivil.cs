using System;
using System.Collections.Generic;

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
//ORIGINAL LINE: @Entity @Table(name = "estado_civil") @XmlRootElement @NamedQueries({ @NamedQuery(name = "EstadoCivil.findAll", query = "SELECT e FROM EstadoCivil e"), @NamedQuery(name = "EstadoCivil.findByIdEstadoCivil", query = "SELECT e FROM EstadoCivil e WHERE e.idEstadoCivil = :idEstadoCivil"), @NamedQuery(name = "EstadoCivil.findByDescripcionEstadoCivil", query = "SELECT e FROM EstadoCivil e WHERE e.descripcionEstadoCivil = :descripcionEstadoCivil")}) public class EstadoCivil implements java.io.Serializable
	[Serializable]
	public class EstadoCivil
	{

		private const long serialVersionUID = 1L;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Id @GeneratedValue(strategy = javax.persistence.GenerationType.IDENTITY) @Basic(optional = false) @Column(name = "id_estado_civil") private System.Nullable<short> idEstadoCivil;
		private short? idEstadoCivil;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "descripcion_estado_civil") private String descripcionEstadoCivil;
		private string descripcionEstadoCivil;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @OneToMany(cascade = javax.persistence.CascadeType.ALL, mappedBy = "estadoCivilIdEstadoCivil") private java.util.List<Cliente> clienteList;
		private IList<Cliente> clienteList;

		public EstadoCivil()
		{
		}

		public EstadoCivil(short? idEstadoCivil)
		{
			this.idEstadoCivil = idEstadoCivil;
		}

		public EstadoCivil(short? idEstadoCivil, string descripcionEstadoCivil)
		{
			this.idEstadoCivil = idEstadoCivil;
			this.descripcionEstadoCivil = descripcionEstadoCivil;
		}

		public virtual short? IdEstadoCivil
		{
			get
			{
				return idEstadoCivil;
			}
			set
			{
				this.idEstadoCivil = value;
			}
		}


		public virtual string DescripcionEstadoCivil
		{
			get
			{
				return descripcionEstadoCivil;
			}
			set
			{
				this.descripcionEstadoCivil = value;
			}
		}


//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @XmlTransient public java.util.List<Cliente> getClienteList()
		public virtual IList<Cliente> ClienteList
		{
			get
			{
				return clienteList;
			}
			set
			{
				this.clienteList = value;
			}
		}


		public override int GetHashCode()
		{
			int hash = 0;
			hash += (idEstadoCivil != null ? idEstadoCivil.GetHashCode() : 0);
			return hash;
		}

		public override bool Equals(object @object)
		{
			// TODO: Warning - this method won't work in the case the id fields are not set
			if (!(@object is EstadoCivil))
			{
				return false;
			}
			EstadoCivil other = (EstadoCivil) @object;
			if ((this.idEstadoCivil == null && other.idEstadoCivil != null) || (this.idEstadoCivil != null && !this.idEstadoCivil.Equals(other.idEstadoCivil)))
			{
				return false;
			}
			return true;
		}

		public override string ToString()
		{
			return "dto.clases.EstadoCivil[ idEstadoCivil=" + idEstadoCivil + " ]";
		}

	}

}