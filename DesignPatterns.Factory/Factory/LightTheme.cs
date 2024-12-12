using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factory
{
    public class LightTheme : ITheme
    {
        public string TextColor => "Black";
        public string BgrColor => "White";
    }

    public class ReplaceableThemeFactory {
        private readonly List<WeakReference<Ref<ITheme>>> _themes = new List<WeakReference<Ref<ITheme>>>();

        private ITheme createThemeImpl(bool dark) {
            return dark ? new DarkTheme() : new LightTheme();
        }  
        public Ref<ITheme> CreateTheme(bool dark) {
            var r = new Ref<ITheme>(createThemeImpl(dark));
            _themes.Add(new(r));
            return r;
        }

        public void ReplaceTheme(bool dark) {
            foreach (var weakReference in _themes) {
                if (weakReference.TryGetTarget(out var themeRef)) {
                    themeRef.Value = createThemeImpl(dark);
                }
            }
        }
    }
}