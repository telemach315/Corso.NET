namespace WorkerServiceCopiatore
{
    public class Worker : BackgroundService
    {
        private readonly string sorgente = @"C:\Sorgente";
        private readonly string destA = @"C:\DestinazioneA";
        private readonly string destB = @"C:\DestinazioneB";

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using FileSystemWatcher watcher = new FileSystemWatcher(sorgente);

            // Aggiungo il listener per 'ascoltare' l'evento di creazione di nuovi file
            watcher.Created += (sender, e) =>
            {
                string nomeFile = e.Name!;
                string percorsoOrigine = e.FullPath;
                
                AspettaCheIlFileSiaLibero(percorsoOrigine);

                File.Copy(percorsoOrigine, Path.Combine(destA, nomeFile));
                File.Copy(percorsoOrigine, Path.Combine(destB, nomeFile));
                File.Delete(percorsoOrigine);
            };

            // Abilito il watcher ad intercettare gli eventi
            watcher.EnableRaisingEvents = true;

            // Il Worker deve restare in esecuzione finché non viene fermato il servizio
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(1000, stoppingToken);
            }
        }
        private static void AspettaCheIlFileSiaLibero(string percorso)
        {
            while (true)
            {
                try
                {
                    // Provo ad aprire il file in modalità esclusiva. 
                    // Se ci riusco, significa che non ci sono processi che lo stanno usando.
                    using (FileStream fs = File.Open(percorso, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                    {
                        return; // File libero, usciamo dal ciclo
                    }
                }
                catch (IOException)
                {
                    // Il file è ancora occupato, aspettiamo mezzo secondo e riproviamo
                    Thread.Sleep(500);
                }
            }
        }
    }
}
