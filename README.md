# Read-Only and Enabled State Binding

The example uses **BaseColumn.IsEnabledBinding** property to disable the **StartDate** and **Due Date** cells if the **Progress** value equals **100%**:

![](https://github.com/DevExpress-Examples/wpf-grid-read-only-and-enabled-binding/blob/20.2.1%2B/grid-enabled-binding.png)

... and the **BaseColumn.IsReadOnlyBinding** property to make the **Progress** cells read-only if a task has subtasks:

![](https://github.com/DevExpress-Examples/wpf-grid-read-only-and-enabled-binding/blob/20.2.1%2B/grid-read-only-binding.png)
