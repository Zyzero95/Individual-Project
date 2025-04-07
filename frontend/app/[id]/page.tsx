import { fetchAnimal } from "../Actions/fetch";
import styles from "./page.module.css"
import anicardStyle from "../Components/Animal Card/animalcard.module.css"

export default async function page({ params }: {params: Promise<{id: number}>}) {

    const id = (await params).id;

    const data = await fetchAnimal(id);
    
  return (
    <main className={styles.idPage}>
      <h2>{data?.name}</h2>
      <section className={anicardStyle.anicardEnvSection}>
        {data?.environment.map((env) => <p key={env} className={`${anicardStyle.anicardEnv}${env}`}>{env == "CoralReef" ? "Coral Reef" : env == "DeepOcean" ? "Deep Ocean" : env == "RockyReefs" ? "Rocky Reefs": env}</p>)}
      </section>
      <p>{data?.species}</p>
      <p>{data?.foodPreference}</p>
      <p>{data?.description}</p>
    </main>
  )
}
