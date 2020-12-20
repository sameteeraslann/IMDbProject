using IMDbProject.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbProject.EntityLayer.Entites.Inferfaces
{
   public interface IBaseEntity
    {
        // Assigned Tabloların sadece BaseEntity kalıtım aldıkları "Id" parametresinin görünmesi açısından IBaseEntity.cs açıp aşağıdaki propörtüleri istediğimiz tablolara implement ettik.
        DateTime? CreateDate { get; set; } //"Nullable = ?" Boş geçilebilir.
        DateTime? ModifiedDate { get; set; }
        DateTime? PassivedDate { get; set; }

        
        Status Status { get ; set; }

    }
}
