using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SubmitModel
{
    /// <summary>
    /// 公共实体基类的公共接口，用于释放对象分配空间
    /// 所有实体模型的父类接口。该接口通过继承接口 IDisposable 可以实现自动实现垃圾回收的效果。实体的调用Dispose() 方法来手动释放占用的内存，
    /// 同时也可以使用using 关键字来控制实体的作用域范围，并及时释放内存
    /// </summary>
    public interface IEntity : IDisposable
    {
    }
}
