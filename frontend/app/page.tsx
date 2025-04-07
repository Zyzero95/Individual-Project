import fetchAllAnimals from "./Actions/fetch";
import AnimalCard from "./Components/Animal Card/animalcard";
import styles from "./page.module.css"

// Call fetch function to get all Animal Data.
export default async function Home() {
  const data = await fetchAllAnimals();
  
  // Maps out Animal data and feed them to the AnimalCard Component.
  return (
    <main className={styles.main}>
      {data?.map((animal) => <AnimalCard key={animal.id} data={animal}/>)}
    </main>
  );
}
