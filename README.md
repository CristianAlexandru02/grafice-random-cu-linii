# Grafice random cu linii

Programul afiseaaza *10000 de linii* pozitionate aleator.
Si culoarea liniilor este **aleatoare**.

## Cod pentru linii aleatoare

```cs
 int x1=r.Next(this.Width);
 int y1=r.Next(this.Height);
 int x2=r.Next(this.Width);
 int y2 = r.Next(this.Height);

 g.DrawLine(p, x1, y1, x2, y2);

```
