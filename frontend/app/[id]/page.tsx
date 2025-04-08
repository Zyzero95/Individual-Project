import { fetchAnimal } from "../Actions/fetch";
import styles from "./page.module.css"
import AnimalIdCard from "../Components/Animal Card/animalIdCard";


export default async function page({ params }: {params: Promise<{id: number}>}) {

    const id = Number((await params).id);
    const data = await fetchAnimal(id);
    
    

  return (
    <main className={styles.idPage}>
      {data === null ? <p>There was a problem fetching the Animal.</p> : <AnimalIdCard data={data}/>}
    </main>
  )
}
