# Introduction
This repository is used to investigate Memory leaks in WPF

# TabControl
## Combobox - Project: WPF.MemoryLeak.Tests.TabControl.Simple
If a Combobox is part of a UserControl that is displayed in a TabItem and the TabItems are removed from the TabControl, they can't be reclaimed and remain in Memory, because of handlers set by the Combobox.


