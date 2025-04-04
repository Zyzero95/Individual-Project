import fetchAllAnimals from "./Actions/fetch";
import AnimalCard from "./Components/Animal Card/animalcard";
import styles from "./page.module.css"

export default async function Home() {
  const data = await fetchAllAnimals();
  
  
  return (
    <main className={styles.main}>
      {data?.map((animal) => <AnimalCard key={animal.id} data={animal}/>)}
    </main>
  );
}
