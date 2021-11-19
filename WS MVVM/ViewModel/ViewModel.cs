using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WS_MVVM
{
    public class ViewModel
    {

        private MajModel model;
        private View.Interface1 view;


        public ViewModel(View.Interface1 view)
        {
            model = new MajModel();
            this.view = view;

        }

        public void call(string x)
        {
            string vmString = model.toUpperModel(x);
            this.view.update(vmString);
        }


    }
}

