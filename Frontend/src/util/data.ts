export function dataValida(dateString: string): boolean {
  const date = new Date(dateString);

  return !isNaN(date.getTime()) && dateString === date.toISOString().slice(0, 10);
}