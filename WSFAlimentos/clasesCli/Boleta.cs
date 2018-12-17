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
//ORIGINAL LINE: @Entity @Table(name = "boleta") @XmlRootElement @NamedQueries({ @NamedQuery(name = "Boleta.findAll", query = "SELECT b FROM Boleta b"), @NamedQuery(name = "Boleta.findByIdBoleta", query = "SELECT b FROM Boleta b WHERE b.idBoleta = :idBoleta")}) public class Boleta implements java.io.Serializable
	[Serializable]
	public class Boleta
	{

		private const long serialVersionUID = 1L;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Id @GeneratedValue(strategy = javax.persistence.GenerationType.IDENTITY) @Basic(optional = false) @Column(name = "id_boleta") private System.Nullable<int> idBoleta;
		private int? idBoleta;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @JoinColumn(name = "ventas_idventas", referencedColumnName = "idventas") @ManyToOne(optional = false) private Ventas ventasIdventas;
		private Ventas ventasIdventas;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @OneToMany(cascade = javax.persistence.CascadeType.ALL, mappedBy = "boletaIdBoleta") private java.util.List<Detalle> detalleList;
		private IList<Detalle> detalleList;

		public Boleta()
		{
		}

		public Boleta(int? idBoleta)
		{
			this.idBoleta = idBoleta;
		}

		public virtual int? IdBoleta
		{
			get
			{
				return idBoleta;
			}
			set
			{
				this.idBoleta = value;
			}
		}


		public virtual Ventas VentasIdventas
		{
			get
			{
				return ventasIdventas;
			}
			set
			{
				this.ventasIdventas = value;
			}
		}


//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @XmlTransient public java.util.List<Detalle> getDetalleList()
		public virtual IList<Detalle> DetalleList
		{
			get
			{
				return detalleList;
			}
			set
			{
				this.detalleList = value;
			}
		}


		public override int GetHashCode()
		{
			int hash = 0;
			hash += (idBoleta != null ? idBoleta.GetHashCode() : 0);
			return hash;
		}

		public override bool Equals(object @object)
		{
			// TODO: Warning - this method won't work in the case the id fields are not set
			if (!(@object is Boleta))
			{
				return false;
			}
			Boleta other = (Boleta) @object;
			if ((this.idBoleta == null && other.idBoleta != null) || (this.idBoleta != null && !this.idBoleta.Equals(other.idBoleta)))
			{
				return false;
			}
			return true;
		}

		public override string ToString()
		{
			return "dto.clases.Boleta[ idBoleta=" + idBoleta + " ]";
		}

	}

}