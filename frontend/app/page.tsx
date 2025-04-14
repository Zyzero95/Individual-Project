import fetchAllAnimals from "./Actions/fetch";
import AnimalCard from "./Components/Animal Card/animalcard";
import Pagination from "./Components/Pagination/pagination";
import styles from "./page.module.css";

// Call fetch function to get all Animal Data, Uses searchParams and slicing data array to create pagination functionality. Sets conditions for buttons to become disabled for Pagination Component.
export default async function Home({ searchParams }: { searchParams: Promise<{ [key: string]: string | undefined }>}) {

  const {page = '1', perPage = '6'} =  await searchParams;

  const start = (Number(page) - 1) * Number(perPage);
  const end = start + Number(perPage);

  const data = await fetchAllAnimals();
  if(!data){
    throw new Error("Fetch failed. No animals present.");
  }
  const entries = data.slice(start, end);
  
  // Maps out Animal data and feed them to the AnimalCard Component.
  return (
    <main className={styles.main}>
        {entries.map((animal) => <AnimalCard key={animal.id} data={animal}/>)}
        <Pagination hasNextPage={end < data.length} hasPrevPage={start > 0}/>
    </main>
  );
}