using ControlAllTheThings.BoardComponents;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControlAllTheThings
{
    public class VirtualBoardControl : UserControl
    {
        protected readonly List<BaseComponent> _components = new List<BaseComponent>();
        protected BoardInterface _board;

        public virtual void SetBoardInterface( BoardInterface board )
        {
            _board = board;

            foreach( BaseComponent c in _components )
            {
                c.SetBoardInterface( _board );
            }
        }

        public virtual void SaveSettings( Settings s )
        {
            foreach( BaseComponent c in _components )
            {
                c.SaveSettings( s );
            }
        }

        public virtual void LoadSettings( Settings s )
        {
            foreach( BaseComponent c in _components )
            {
                c.LoadSettings( s );
            }
        }

        protected override void OnControlAdded( ControlEventArgs e )
        {
            base.OnControlAdded( e );

            if( e.Control is BaseComponent )
            {
                _components.Add( (BaseComponent)e.Control );
            }
        }
    }
}
