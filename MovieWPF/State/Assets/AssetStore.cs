using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNet.Data.Models;
using MovieWPF.State.Accounts;

namespace MovieWPF.State.Assets
{

    public class AssetStore

    {
        private readonly IAccountStore _accountStore;
        public event Action StateChanged;



        public AssetStore(IAccountStore accountStore)
        {
            _accountStore = accountStore;
            _accountStore.StateChanged += OnStateChanged;
        }

        private void OnStateChanged()
        {
            StateChanged?.Invoke();
        }

    }
}
