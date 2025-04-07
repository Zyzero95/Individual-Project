import { fetchAnimal } from "../Actions/fetch";
import styles from "./page.module.css"

export default async function page({ params }: {params: Promise<{id: number}>}) {

    const id = (await params).id;

    const data = await fetchAnimal(id);
    
  return (
    <main className={styles.idPage}>
      <h2>{data?.name}</h2>
    </main>
  )
}
