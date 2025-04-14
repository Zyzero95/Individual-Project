import fetchAllAnimals from "./Actions/fetch";
import Pagination from "./Components/Pagination/pagination";
import Query from "./Components/Search and filter features/query";
import Search from "./Components/Search and filter features/search";
import styles from "./page.module.css";

// Call fetch function to get all Animal Data, Uses searchParams and slicing data array to create pagination functionality. Sets conditions for buttons to become disabled for Pagination Component.
export default async function Home({ searchParams }: { searchParams: Promise<{ [key: string]: string | undefined; query: string | undefined; filter: string | undefined }>}) {

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
        <Search/>
        <Query searchParams={searchParams} data={entries}/>
        <Pagination hasNextPage={end < data.length} hasPrevPage={start > 0}/>
    </main>
  );
}