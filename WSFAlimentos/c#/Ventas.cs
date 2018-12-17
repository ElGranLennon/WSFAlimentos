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
//ORIGINAL LINE: @Entity @Table(name = "ventas") @XmlRootElement @NamedQueries({ @NamedQuery(name = "Ventas.findAll", query = "SELECT v FROM Ventas v"), @NamedQuery(name = "Ventas.findByIdventas", query = "SELECT v FROM Ventas v WHERE v.idventas = :idventas"), @NamedQuery(name = "Ventas.findByActivoV", query = "SELECT v FROM Ventas v WHERE v.activoV = :activoV"), @NamedQuery(name = "Ventas.findByFechaVenta", query = "SELECT v FROM Ventas v WHERE v.fechaVenta = :fechaVenta"), @NamedQuery(name = "Ventas.findByFechaEntrega", query = "SELECT v FROM Ventas v WHERE v.fechaEntrega = :fechaEntrega")}) public class Ventas implements java.io.Serializable
	[Serializable]
	public class Ventas
	{

		private const long serialVersionUID = 1L;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Id @GeneratedValue(strategy = javax.persistence.GenerationType.IDENTITY) @Basic(optional = false) @Column(name = "idventas") private System.Nullable<int> idventas;
		private int? idventas;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "activo_v") private System.Nullable<char> activoV;
		private char? activoV;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 45) @Column(name = "fecha_venta") private String fechaVenta;
		private string fechaVenta;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Size(max = 45) @Column(name = "fecha_entrega") private String fechaEntrega;
		private string fechaEntrega;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @JoinColumn(name = "cliente_id_cliente", referencedColumnName = "id_cliente") @ManyToOne(optional = false) private Cliente clienteIdCliente;
		private Cliente clienteIdCliente;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @OneToMany(cascade = javax.persistence.CascadeType.ALL, mappedBy = "ventasIdventas") private java.util.List<Boleta> boletaList;
		private IList<Boleta> boletaList;

		public Ventas()
		{
		}

		public Ventas(int? idventas)
		{
			this.idventas = idventas;
		}

		public Ventas(int? idventas, char? activoV, string fechaVenta)
		{
			this.idventas = idventas;
			this.activoV = activoV;
			this.fechaVenta = fechaVenta;
		}

		public virtual int? Idventas
		{
			get
			{
				return idventas;
			}
			set
			{
				this.idventas = value;
			}
		}


		public virtual char? ActivoV
		{
			get
			{
				return activoV;
			}
			set
			{
				this.activoV = value;
			}
		}


		public virtual string FechaVenta
		{
			get
			{
				return fechaVenta;
			}
			set
			{
				this.fechaVenta = value;
			}
		}


		public virtual string FechaEntrega
		{
			get
			{
				return fechaEntrega;
			}
			set
			{
				this.fechaEntrega = value;
			}
		}


		public virtual Cliente ClienteIdCliente
		{
			get
			{
				return clienteIdCliente;
			}
			set
			{
				this.clienteIdCliente = value;
			}
		}


//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @XmlTransient public java.util.List<Boleta> getBoletaList()
		public virtual IList<Boleta> BoletaList
		{
			get
			{
				return boletaList;
			}
			set
			{
				this.boletaList = value;
			}
		}


		public override int GetHashCode()
		{
			int hash = 0;
			hash += (idventas != null ? idventas.GetHashCode() : 0);
			return hash;
		}

		public override bool Equals(object @object)
		{
			// TODO: Warning - this method won't work in the case the id fields are not set
			if (!(@object is Ventas))
			{
				return false;
			}
			Ventas other = (Ventas) @object;
			if ((this.idventas == null && other.idventas != null) || (this.idventas != null && !this.idventas.Equals(other.idventas)))
			{
				return false;
			}
			return true;
		}

		public override string ToString()
		{
			return "dto.clases.Ventas[ idventas=" + idventas + " ]";
		}

	}

}